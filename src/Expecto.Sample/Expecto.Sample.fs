module Expecto.Sample

open Expecto.Logging
open Expecto.Logging.Message
open Verify.Expecto
open Expecto
open System.Diagnostics

Expecto.Expect.defaultDiffPrinter <- Expecto.Diff.colourisedDiff

let tests =
  testAsync  "A simple test" {
    let x=Verify.Expecto.Verifier.Verify "Hello World"
    let subject = "Hello Wosrld"
    Trace.WriteLine "xxx"
    Expect.equal subject "Hello World" "The strings should equal"
    return ()
  }

[<EntryPoint>]
let main args =
  runTestsWithCLIArgs [] args tests
