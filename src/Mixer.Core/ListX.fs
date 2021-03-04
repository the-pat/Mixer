namespace Mixer.Core

module ListX =
    let shuffledList min max =
        SeqX.range min max |> SeqX.shuffle |> Seq.toList
