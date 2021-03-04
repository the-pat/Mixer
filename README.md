<p align="center" style="background: rgb(250,235,215);
background: linear-gradient(126deg, rgba(250,235,215,1) 60%, rgba(169,195,244,1) 100%);">
  <img src="./assets/mixer.svg" alt="Food Mixer by Dmitry Mirolyubov">
</p>

# Mixer

[![Build and Test](https://github.com/the-pat/Mixer/actions/workflows/build-and-test.yml/badge.svg)](https://github.com/the-pat/Mixer/actions/workflows/build-and-test.yml)

> Mixes sequences and lists

This is a simple library to simplify the process of creating a randomized list of integers.

## Usage

```fsharp

let shuffledList: int list =
    Mixer.Core.ListX.shuffledList 1 10000
// [ 9717; 408; 1261; 8042; ...]

let orderedSeq: int seq =
    Mixer.Core.SeqX.range 1 5
// seq { 1; 2; 3; 4; 5; }

let shuffledSeq: int seq =
    orderedSeq |> Mixer.Core.SeqX.shuffle
// seq { 2; 4; 3; 5; 1; }

let random = System.Random(42)
let shuffledSeq2: int seq =
    orderedSeq |> Mixer.Core.SeqX.shuffle2 random
// seq { 3; 2; 4; 5; 1; }

```

## Attribution

- [Food Mixer by Dmitry Mirolyubov](https://thenounproject.com/term/food-mixer/1234394/) from the [Noun Project](https://thenounproject.com/)
