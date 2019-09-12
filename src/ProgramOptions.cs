﻿using CommandLine;

namespace ReferenceAssemblyGenerator
{
    public class ProgramOptions
    {
        [Option('o', "output", Required = false, HelpText = "Sets the output file")]
        public string OutputFile { get; set; }

        [Option("keep-non-public", Required = false, HelpText = "Sets if non-public metadata should be kept")]
        public bool KeepNonPublic { get; set; }

        [Value(0, MetaName = "assemblyPath", Required = true, HelpText = "Path to assembly to generate reference assembly for.")]
        public string AssemblyPath { get; set; }
    }
}