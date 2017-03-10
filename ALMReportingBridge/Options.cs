using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace ALMReportingBridge
{
    public enum Operations
    {
        CopyTS, CreateTS, RecordRunResult, UpdateTSField, AddTestToTS, UploadAttachTS, UploadAttachRun
    }
   public abstract class CommonOptions
    {

        [Option("operation", HelpText = "The operation you wish to perform", Required = true)]
        public Operations Operation { get; set; }


        [Option('s', "server", HelpText = "URL of HPE ALM Server.", Required = true)]
        public string AlmUrl { get; set; }

        [Option('u', "username",
            HelpText = "ALM username.", Required = true)]
        public string Username { get; set; }

        [Option('p', "password",
            HelpText = "ALM password.", Required = true)]
        public string Password { get; set; }

        [Option('d', "domain", HelpText = "ALM project domain to log in to", Required = true)]
        public string Domain { get; set; }

        [Option('r', "project", HelpText = "ALM project to log in to", Required = true)]
        public string Project { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            // this without using CommandLine.Text
            //  or using HelpText.AutoBuild
            // var usage = new StringBuilder();
            // usage.AppendLine("Quickstart Application 1.0");
            // usage.AppendLine("Read user manual for usage instructions...");
            // return usage.ToString();
            return HelpText.AutoBuild(this, (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }


    public class Options : CommonOptions
    {

        [Option('t', "template", HelpText = "Copy Test Set: The test set ID of the test set to be copied", MutuallyExclusiveSet = "Copy Test Set")]
        public int TemplateTSId { get; set; }

        [Option('d', "destination", HelpText = "Copy Test Set: The folder path where the new test set will be created", MutuallyExclusiveSet = "Copy Test Set")]
        public string DestinationPath { get; set; }

        [Option('n', "name", HelpText = "Copy Test Set: The name of the newly created test set", MutuallyExclusiveSet = "Copy Test Set")]
        public string TSName { get; set; }



        [Option("testset", HelpText = "The test set ID to add tests to", MutuallyExclusiveSet = "Add Test to Test Set")]
        public int TestSetId { get; set; }

       

        [Option('c', "config", HelpText = "The test configuration ID to add to the test set", MutuallyExclusiveSet = "Add Test to Test Set")]
        public int TestConfigId { get; set; }


    }


}
