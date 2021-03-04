namespace Mixer.Core

module SeqX =
    /// Generates a sequence of integers from `min
    let range first last =
        if first > last then
            seq { last .. first } |> Seq.rev
        else
            seq { first .. last }
