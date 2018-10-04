﻿namespace Stryker.CLI
{
    public static class CLIOptions
    {
        public static readonly CLIOption<string> ConfigFilePath = new CLIOption<string>
        {
            ArgumentName = "--config-file-path",
            ArgumentShortName = "-cp <path>",
            ArgumentDescription = "Sets the config-file-path relative to current workingDirectory | stryker-config.json (default)",
            DefaultValue = "stryker-config.json"
        };

        public static readonly CLIOption<string> Reporter = new CLIOption<string>
        {
            ArgumentName = "--reporter",
            ArgumentShortName = "-r <reporter>",
            ArgumentDescription = "Sets the reporter | Options [Console (default), ReportOnly]",
            DefaultValue = "Console",
            JsonKey = "reporter"
        };

        public static readonly CLIOption<string> LogLevel = new CLIOption<string>
        {
            ArgumentName = "--log-console",
            ArgumentShortName = "-l <logLevel>",
            ArgumentDescription = "Sets the logging level | Options [error, warning (default), info, debug, trace]",
            DefaultValue = "warning",
            JsonKey = "log-level"
        };

        public static readonly CLIOption<bool> UseLogFile = new CLIOption<bool>
        {
            ArgumentName = "--log-file",
            ArgumentShortName = "-f <useLogFile>",
            ArgumentDescription = "Use log-file | Options [false (Default), true]",
            DefaultValue = false,
            JsonKey = "log-file"
        };

        public static readonly CLIOption<int> AdditionalTimeoutMS = new CLIOption<int>
        {
            ArgumentName = "--timeout-ms",
            ArgumentShortName = "-t <ms>",
            ArgumentDescription = "When passed, a logfile will be created for this mutationtest run on trace level",
            DefaultValue = 30000,
            JsonKey = "timeout-ms"
        };

        public static readonly CLIOption<string> ProjectName = new CLIOption<string>
        {
            ArgumentName = "--project",
            ArgumentShortName = "-p <projectName>",
            ArgumentDescription = @"Used for matching the project references when finding the project to mutate. Example: ""ExampleProject.csproj""",
            JsonKey = "project-name"
        };

        public static readonly CLIOption<int> ThresholdBreak = new CLIOption<int>
        {
            ArgumentName = "--threshold-break",
            ArgumentShortName = "-tb <thresholdBreak>",
            ArgumentDescription = "Set the minimum mutation score threshold. Anything below this score will return a non-zero exit code. | 60 (default)",
            DefaultValue = 60,
            JsonKey = "threshold-break"
        };      

        public static readonly CLIOption<int> ThresholdLow = new CLIOption<int>
        {
            ArgumentName = "--threshold-low",
            ArgumentShortName = "-tl <thresholdLow>",
            ArgumentDescription = "Set the lower bound of the mutation score threshold. It will not fail the test. | 70 (default)",
            DefaultValue = 70,
            JsonKey = "threshold-low"
        };    
        
        public static readonly CLIOption<int> ThresholdHigh = new CLIOption<int>
        {
            ArgumentName = "--threshold-high",
            ArgumentShortName = "-th <thresholdHigh>",
            ArgumentDescription = "Set the prefered mutation score threshold. | 80 (default)",
            DefaultValue = 80,
            JsonKey = "threshold-high"
        };                    
    }
}
