namespace Mixer.Core

module SeqX =
    /// Generates a sequence of integers from `min` to `max`
    let range first last =
        if first > last then
            seq { last .. first } |> Seq.rev
        else
            seq { first .. last }

    /// Shuffles the sequence with the given random seed.
    let shuffle2 (rnd: System.Random) seq = seq |> Seq.sortBy (fun _ -> rnd.Next())

    /// Shuffles the sequence.
    let shuffle seq =
        let rnd = System.Random() in seq |> shuffle2 rnd
