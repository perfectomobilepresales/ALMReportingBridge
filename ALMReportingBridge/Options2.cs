using CommandLine;
using CommandLine.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALMReportingBridge
{

    enum Operations
    {
        CopyTS, CreateTS, RecordRunResult, UpdateTSField, AddTestToTS, UploadAttachTS, UploadAttachRun
    }




    abstract class CommonOptionsx
    {

        [Option('s', "server", HelpText = "URL of HPE ALM Server.")]
        string AlmUrl { get; set; }

        [Option('u', "username",
            HelpText = "ALM username.")]
        string Username { get; set; }

        [Option('p', "password",
            HelpText = "ALM password.")]
        string Password { get; set; }

        [Option('d', "domain", HelpText = "ALM project domain to log in to")]
        string Domain { get; set; }

        [Option('r', "project", HelpText = "ALM project to log in to")]
        string Project { get; set; }
    }


   
    class CopyTSOptions : CommonOptionsx
    {
        
        [Option('t', "template", HelpText = "The test set ID of the test set to be copied")]
        int TemplateTSId { get; set; }

        [Option('d', "destination", HelpText = "The folder path where the new test set will be created")]
        string DestinationPath { get; set; }

        [Option('n', "name", HelpText = "The name of the newly created test set")]
        string Name { get; set; }
    }


    class Optionsx
    {
        
        [Option("copyts", HelpText = "Copy test set.")]
        public 

        [HelpOption]
        public string GetUsage()
        {
            // this without using CommandLine.Text
            var usage = new StringBuilder();
            usage.AppendLine("Quickstart Application 1.0");
            usage.AppendLine("Read user manual for usage instructions...");
            return usage.ToString();
        }

        [ParserState]
        public IParserState LastParserState { get; set; }
    }




}
