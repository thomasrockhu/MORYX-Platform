﻿// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

namespace Moryx.Model.Configuration
{
    /// <summary>
    /// Class to store information of a database update
    /// </summary>
    public class DatabaseUpdateInformation
    {
        /// <summary>
        /// Name of the update
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the update is installed
        /// </summary>
        public bool IsApplied { get; set; }
    }
}