﻿// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Lepo.i18n Contributors.
// All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Lepo.i18n
{
    internal class Yaml
    {
        /// <summary>
        /// Creates a hashed <see langword="int"/> representation of <see langword="string"/>.
        /// </summary>
        /// <param name="value">Value to be hashed.</param>
        /// <returns></returns>
        public static uint Map(string value)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] hashed = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(value));

            return BitConverter.ToUInt32(hashed, 0);
        }

        /// <summary>
        /// Creates new collection of mapped keys with translated values.
        /// </summary>
        /// <param name="path">Path to yaml file.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static Dictionary<uint, string> FromPath(string path)
        {
            // TODO: Implement search application
            throw new NotImplementedException("Yaml from path is not yet implemented");

            return new Dictionary<uint, string>() { };
        }

        /// <summary>
        /// Creates new collection of mapped keys with translated values.
        /// </summary>
        /// <param name="yamlContent">String containing Yaml.</param>
        /// <returns></returns>
        public static Dictionary<uint, string> FromString(string yamlContent)
        {
            Dictionary<uint, string> keyValueCollection = new() { };

            string[] yamlLines = yamlContent.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None
            );

            if (yamlLines.Length < 1)
            {
                return keyValueCollection;
            }

            foreach (string yamlLine in yamlLines)
            {
                if (yamlLine.StartsWith("#") || String.IsNullOrEmpty(yamlLine))
                    continue;

                string[] pair = yamlLine.Split(new[] { ':' }, 2);

                if (pair.Length < 2)
                    continue;

                uint mappedKey = Map(pair[0].Trim());

                if (!keyValueCollection.ContainsKey(mappedKey))
                    keyValueCollection.Add(mappedKey, pair[1].Trim());
            }

            return keyValueCollection;
        }
    }
}