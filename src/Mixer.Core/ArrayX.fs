namespace Mixer.Core

module ArrayX =
    /// Generates an array of integers from `min` to `max`.
    let range first last =
        if first > last then
            [| last .. first |] |> Array.rev
        else
            [| first .. last |]

    /// Shuffles the array with the given random seed.
    let shuffle2 (rnd: System.Random) arr =
        arr |> Array.sortBy (fun _ -> rnd.Next())

    /// Shuffles the array.
    let shuffle arr =
        let rnd = System.Random() in arr |> shuffle2 rnd
