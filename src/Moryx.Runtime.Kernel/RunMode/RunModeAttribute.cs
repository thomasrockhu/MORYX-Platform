// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System;
using Moryx.Container;

namespace Moryx.Runtime.Kernel
{
    /// <summary>
    /// Registration attribute for IRuntimeEnvironment
    /// </summary>
    public class RunModeAttribute : GlobalComponentAttribute
    {
        /// <summary>
        /// Type of options parsed from arguments
        /// </summary>
        public Type OptionType { get; }

        /// <summary>
        /// Constructor with life cycle
        /// </summary>
        /// <param name="optionType">Type of options parsed from arguments</param>
        public RunModeAttribute(Type optionType)
            : base(LifeCycle.Singleton, typeof(IRunMode))
        {
            OptionType = optionType;
        }
    }
}
