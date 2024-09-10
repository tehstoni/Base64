# Base64 Encoder/Decoder

This is a simple C# console application for encoding and decoding Base64 strings. The program can encode and decode strings via command-line arguments or standard input.

## Features

- **Encode to Base64**: Convert plain text to Base64.
- **Decode from Base64**: Convert Base64 back to plain text.
- **Piping Support**: Accept input from standard input for flexible usage.

## Requirements

- .NET SDK 5.0 or higher.

## Usage

The program accepts the following command-line arguments:

- `-e`: Encode a string to Base64.
- `-d`: Decode a Base64 string back to plain text.
- `-p`: Pipe mode. Accepts input from standard input for encoding or decoding.

### Encoding a string to Base64

```powershell
Base64 -e "Your text here"

```

```powershell
'S2FwcGExMjM=' | Base64.exe -p -d
Kappa123
```

```powershell
'Kappa123' | Base64.exe -p -e
S2FwcGExMjM=
```
