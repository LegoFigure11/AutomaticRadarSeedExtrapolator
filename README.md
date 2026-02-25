# AutomaticRadarSeedExtrapolator (ARSE)

[![.NET Core Desktop](https://img.shields.io/github/actions/workflow/status/LegoFigure11/AutomaticRadarSeedExtrapolator/dotnet-desktop.yml?branch=master)](https://github.com/LegoFigure11/AutomaticRadarSeedExtrapolator/actions/workflows/dotnet-desktop.yml)
[![GitHub License](https://img.shields.io/github/license/legofigure11/AutomaticRadarSeedExtrapolator?color=ff69b4)](https://github.com/LegoFigure11/AutomaticRadarSeedExtrapolator/blob/master/LICENSE.txt)
[![Usage Guide](https://img.shields.io/badge/usage_guide-click_me!-purple)](https://billo-guides.github.io/)
<br />
[![Version](https://img.shields.io/github/v/release/LegoFigure11/AutomaticRadarSeedExtrapolator?label=latest%20release)](https://github.com/LegoFigure11/AutomaticRadarSeedExtrapolator/releases/latest)
![Download Count](https://img.shields.io/github/downloads/LegoFigure11/AutomaticRadarSeedExtrapolator/total?label=total%20downloads)

_by [@LegoFigure11](https://github.com/LegoFigure11/)_

RNG Tool and sys-botbase client for Pokémon Brilliant Diamond & Shining Pearl for the Nintendo Switch.

A comprehensive usage guide brought to you by [Billo-PS](https://github.com/Billo-PS) can be found **[here](https://billo-guides.github.io/)**.


## Features & shortcuts

* Full RNG prediction for Pok&eacute; Radar Chain Continuation and Wild Pokemon.
* Automation for Pok&eacute; Radar Chain Continuation.
* Automated and manual delay calibration.
* Support for Always Shiny and Always Hidden Ability patches.
* Switch connectivity over both Wi-Fi and USB thanks to the sys-botbase homebrew sysmodule.
* Automated seed reading and tracking.
* Included Encounter Slots for every area where the Poké Radar can be used.
* Filtering results based on Species (rather than Encounter Slot), IVs, Shininess, Height (for Jumbo/Teensy mark in Scarlet/Violet), and Rare EC (EC modulo 100 = 0, only useful for catching Dunsparce that evolve in to 3-Segment Dudunsparce in Scarlet/Violet).
* Automatically read TID, SID, Game Version, Chain Count, and Chain Species directly from RAM.
* Read Wild Encounters with the "Read Encounter" button.
* Shift + Click on an IV button or label to apply the effect to every stat (Shift + Max = 31 all, Shift + Min = 0 all, Shift + any stat name = reset all).
* Click on the icon between IVs to switch between IV search modes for that stat: ``~`` for a range (e.g. ``0 ~ 31`` accepting all IVs, ``0 ~ 3`` accepting 0, 1, 2, or 3), or ``||`` for either or (e.g. ``0 || 31`` accepting 0 and 31 only, ``29 || 31`` accepting 29 and 31 only).

## Credits and thanks to

* [@Lusamine](https://github.com/Lusamine/) for research and proo-of-concept linqpad scripts.
* [@Billo-PS](https://github.com/Billo-PS) for research and your endless patience and testing, as well as your incredible guides.

## Disclaimer

Every precaution has been taken to ensure that this program is safe to use, but by using this program you accept that as with any switch homebrew or CFW tools there is a potential risk for your switch to be banned or bricked, and that you alone are responsible for anything that may happen to your own console as a result of using AutomaticRadarSeedExtrapolator or the included sys-botbase.
