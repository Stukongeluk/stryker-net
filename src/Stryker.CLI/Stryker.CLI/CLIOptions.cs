﻿namespace Stryker.CLI
{
    public static class CLIOptions
    {
        public static readonly CLIOption<string> ConfigFilePath = new CLIOption<string>
        {
            ArgumentName = "--configFilePath",
            ArgumentShortName = "-cp <path>",
            ArgumentDescription = "Sets the configFilePath relative to current workingDirectory | stryker-config.json (default)",
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
            ArgumentName = "--logConsole",
            ArgumentShortName = "-l <logLevel>",
            ArgumentDescription = "Sets the logging level | Options [error, warning (default), info, debug, trace]",
            DefaultValue = "warning",
            JsonKey = "logLevel"
        };

        public static readonly CLIOption<bool> UseLogFile = new CLIOption<bool>
        {
            ArgumentName = "--logFile",
            ArgumentShortName = "-f <useLogFile>",
            ArgumentDescription = "Use logFile | Options [false (Default), true]",
            DefaultValue = false,
            JsonKey = "logFile"
        };

        public static readonly CLIOption<int> AdditionalTimeoutMS = new CLIOption<int>
        {
            ArgumentName = "--timeoutMS",
            ArgumentShortName = "-t <ms>",
            ArgumentDescription = "When passed, a logfile will be created for this mutationtest run on trace level",
            DefaultValue = 30000,
            JsonKey = "timeoutMS"
        };

        public static readonly CLIOption<string> ProjectName = new CLIOption<string>
        {
            ArgumentName = "--project",
            ArgumentShortName = "-p <projectName>",
            ArgumentDescription = @"Used for matching the project references when finding the project to mutate. Example: ""ExampleProject.csproj""",
            JsonKey = "projectName"
        };

        public static readonly CLIOption<int> ThresholdBreak = new CLIOption<int>
        {
            ArgumentName = "--threshold-break",
            ArgumentShortName = "-tb <threshold>",
            ArgumentDescription = "Set the minimum mutation score threshold. Anything below this score will return a non-zero exit code. | 60 (default)",
            DefaultValue = 60,
            JsonKey = "thresholdBreak"
        };      

        public static readonly CLIOption<int> ThresholdLow = new CLIOption<int>
        {
            ArgumentName = "--threshold-low",
            ArgumentShortName = "-tl <threshold",
            ArgumentDescription = "Set the lower bound of the mutation score threshold. It will not fail the test. | 70 (default)",
            DefaultValue = 70,
            JsonKey = "thresholdLow"
        };    
        
        public static readonly CLIOption<int> ThresholdHigh = new CLIOption<int>
        {
            ArgumentName = "--threshold-high",
            ArgumentShortName = "-th <threshold",
            ArgumentDescription = "Set the prefered mutation score threshold. | 80 (default)",
            DefaultValue = 80,
            JsonKey = "thresholdHigh"
        };                    
    }
}
