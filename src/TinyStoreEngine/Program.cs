using System;
using CommandLine;

class Program
{
    [Verb("store", HelpText = "Store related operations.")]
    class StoreOptions
    {
        [Option('k', "key", Required = true, HelpText = "key of pair.")]
        public string key { get; set; }

        [Option('v', "value", Required = true, HelpText = "value of pair.")]
        public string value { get; set; }
    }

    [Verb("retrieve", HelpText = "Retrieve related operations.")]
    class RetrieveOptions
    {
        [Option('k', "key", Required = true, HelpText = "data key.")]
        public int key { get; set; }
    }

    static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed<Options>(opts => RunOptionsAndReturnExitCode(opts))
            .WithNotParsed<Options>((errs) => HandleParseError(errs));
    }

    static void RunOptionsAndReturnExitCode(Options opts)
    {
        Console.WriteLine($"Hello, {opts.Name}!");
        if (opts.Age > 0)
        {
            Console.WriteLine($"You are {opts.Age} years old.");
        }
    }

    static void HandleParseError(IEnumerable<Error> errs)
    {
        // Handle errors here
    }
}