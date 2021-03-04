module Tests

open Xunit
open Mixer.Core

[<Theory>]
[<InlineData("Frodo", "Hello Frodo")>]
[<InlineData("Gandalf", "Hello Gandalf")>]
let ``Say.hello/1`` (name: string) (expected: string) =
    Assert.Equal(expected, (Say.hello name))
