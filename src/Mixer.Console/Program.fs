open Mixer.Core

[<EntryPoint>]
let main argv =
    let first = int argv.[0]
    let last = int argv.[1]
    let count = float (abs (last - first) + 1)

    let shuffledList1 = ListX.shuffledList first last
    let shuffledList2 = ListX.shuffledList first last

    let differingElements =
        (List.zip shuffledList1 shuffledList2)
        |> List.indexed
        |> List.filter (fun (_, (elem1, elem2)) -> elem1 <> elem2)

    let differingElementsCount =
        differingElements |> List.length |> float

    printfn "The lists are %.1f%% different" (100. * differingElementsCount / count)
    printfn ""
    printfn "%A" differingElements
    printfn ""

    0
