module SeqX.Tests

open System.Collections.Generic
open Xunit
open Mixer.Core

[<Fact>]
let ``SeqX.range 0 0 returns seq { 0 }`` () =
    let expected = seq { 0 }

    let actual = SeqX.range 0 0

    Assert.Equal<IEnumerable<int>>(expected, actual)

[<Fact>]
let ``SeqX.range 1 3 returns seq { 1; 2; 3 }`` () =
    let expected =
        seq {
            1
            2
            3
        }

    let actual = SeqX.range 1 3

    Assert.Equal<IEnumerable<int>>(expected, actual)

[<Fact>]
let ``SeqX.range 5 3 returns seq { 5; 4; 3 }`` () =
    let expected =
        seq {
            5
            4
            3
        }

    let actual = SeqX.range 5 3

    Assert.Equal<IEnumerable<int>>(expected, actual)
