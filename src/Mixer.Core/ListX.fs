namespace Mixer.Core

module ListX =
    let shuffledList min max =
        ArrayX.range min max
        |> ArrayX.shuffle
        |> Array.toList
