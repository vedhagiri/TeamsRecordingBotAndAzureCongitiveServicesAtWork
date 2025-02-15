﻿// ***********************************************************************
// Assembly         : RecordingBot.Services
// Author           : Vedhagiri Prakasam
// Created          : 09-07-2022
//
// Last Modified By : Vedhagiri
// Last Modified On : 08-17-2022
// ***********************************************************************
// <copyright file="ZipUtils.cs" company="Recosenselabs.com">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using ICSharpCode.SharpZipLib.Zip;
using System.Collections.Generic;
using System.IO;

namespace RecordingBot.Services.Util
{
    /// <summary>
    /// Class ZipUtils.
    /// </summary>
    public static class ZipUtils
    {
        /// <summary>
        /// Enumerate a zip file and return the entries
        /// </summary>
        /// <param name="zipFile">The zip file.</param>
        /// <returns>IEnumerable&lt;System.ValueTuple&lt;ZipEntry, ZipInputStream&gt;&gt;.</returns>
        public static IEnumerable<(ZipEntry, ZipInputStream)> GetEntries(string zipFile)
        {
            using (var fs = File.OpenRead(zipFile))
            {
                using (var zipInputStream = new ZipInputStream(fs))
                {
                    while (zipInputStream.GetNextEntry() is ZipEntry zipEntry)
                    {
                        yield return (zipEntry, zipInputStream);
                    }
                }
            }
        }
    }
}
