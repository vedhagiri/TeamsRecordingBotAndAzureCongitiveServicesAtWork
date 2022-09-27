// Copyright (c) Wictor Wilén. All rights reserved.
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

const webpack = require("webpack");
const Dotenv = require("dotenv-webpack");
const nodeExternals = require("webpack-node-externals");
const ESLintPlugin = require("eslint-webpack-plugin");

const path = require("path");
const fs = require("fs");
const argv = require("yargs").argv;

const debug = argv.debug !== undefined;
const lint = !(argv["no-linting"] || argv.l === true);

const config = [
  {
    entry: {
      server: [path.join(__dirname, "/src/server/server.ts")],
    },
    mode: debug ? "development" : "production",
    output: {
      path: path.join(__dirname, "/dist"),
      filename: "[name].js",
      devtoolModuleFilenameTemplate: debug ? "[absolute-resource-path]" : "[]",
    },
    externals: [nodeExternals()],
    devtool: debug ? "source-map" : "source-map",
    resolve: {
      extensions: [".ts", ".tsx", ".js", ".css", ".scss"],
      alias: {},
    },
    target: "node",
    node: {
      __dirname: false,
      __filename: false,
    },
    module: {
      rules: [
        {
          test: /\.tsx?$/,
          exclude: /node_modules/,
          use: ["ts-loader"],
        },
      ],
    },
    plugins: [],
  },
  {
    entry: {
      client: [path.join(__dirname, "/src/client/client.ts")],
    },
    mode: debug ? "development" : "production",
    output: {
      path: path.join(__dirname, "/dist/web/scripts"),
      filename: "[name].js",
      libraryTarget: "umd",
      library: "cognitiveBot",
      publicPath: "/scripts/",
    },
    externals: {},
    devtool: debug ? "source-map" : "source-map",
    resolve: {
      extensions: [".ts", ".tsx", ".js", ".css", ".scss"],
      alias: {},
    },
    target: "web",
    module: {
      rules: [
        {
          test: /\.css$/,
          use: [
            "style-loader",
            {
              loader: "css-loader",
              options: {
                importLoaders: 1,
                modules: true,
              },
            },
          ],
          include: /\.module\.css$/,
        },
        // { test: /\.scss$/, use: [
        //     { loader: "style-loader" },  // to inject the result into the DOM as a style block
        //     { loader: "css-modules-typescript-loader"},  // to generate a .d.ts module next to the .scss file (also requires a declaration.d.ts with "declare modules '*.scss';" in it to tell TypeScript that "import styles from './styles.scss';" means to load the module "./styles.scss.d.td")
        //     { loader: "css-loader", options: { modules: true } },  // to convert the resulting CSS to Javascript to be bundled (modules:true to rename CSS classes in output to cryptic identifiers, except if wrapped in a :global(...) pseudo class)
        //     { loader: "sass-loader" },  // to convert SASS to CSS
        //     // NOTE: The first build after adding/removing/renaming CSS classes fails, since the newly generated .d.ts typescript module is picked up only later
        // ] },

        {
          test: /\.tsx?$/,
          exclude: /node_modules/,
          use: ["ts-loader"],
        },
      ],
    },
    plugins: [
      new Dotenv({
        systemvars: true,
      }),
    ],
  },
];

if (lint !== false) {
  config[0].plugins.push(
    new ESLintPlugin({ extensions: ["ts", "tsx"], failOnError: false })
  );
  config[1].plugins.push(
    new ESLintPlugin({ extensions: ["ts", "tsx"], failOnError: false })
  );
}

module.exports = config;
