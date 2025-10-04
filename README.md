<!-- Last updated: 251004 -->

<div align="center">

 ![](./.github/Images/Logos/Salnicker-logo_256x256.png)

 ![Version](https://img.shields.io/badge/VERSION-0.9.0-lightgreen?style=for-the-badge)

</div>

> Salnicker has been depreciated, and most of the functionality/code has been moved to [Woolpack](https://github.com/APrettyCoolProgram/woolpack).


# Salnicker

A utility to convert a file of SHA hashes created by 7-zip into individual files.

## Usage

1. Download the latest release
2. Extract `Salnicker-x.y.z.zip`
3. Copy/paste `Salnicker.exe` to the folder that contains the file that contains multiple SHA256 hashes
4. Type `Salnicker %filename%`

For example: `Salnicker FileOfHashes.sha256`

## Known issues

Version 0.9.0 is really bare bones, and won't work if any of the entries in the sha256 file have directories.
