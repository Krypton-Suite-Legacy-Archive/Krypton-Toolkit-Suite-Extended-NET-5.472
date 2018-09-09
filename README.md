# Krypton-Toolkit-Suite-Extended-NET-4.72

=======

## Help needed! If anyone knows how to generate colours based on a base colour, then please contribute to this project, as it'll be appreciated (4 colours are needed). Thanks!

=======

## An extension to the Krypton Toolkit suite of controls for .NET framework 4.7.2

## NOTE: 08/07/2018 Background menu colours will be implemented in the comming weeks. Stay tuned for updates!

======

## 09-09-2018 September Update
* New colour controls and UI options have been implemented to easily create brand new themes
* New application named `Palette Editor` has been implemented to create new themes (89% completed) - feedback would be welcome
* New debugging options
* A new circular picture box
* New API to allow a complementary colour set to be generated.
* New project icon
* Tidy up code

======

## 2018-07-08 Initial Commit
* Reset build paths, so no errors should be incurred.
* One **new** theme called `Slate Silver`, stylised for the 2007/2010 and 2013 theme sets.
* There are now 50+ **new** palettes to choose from.
* A new toolstrip label capable of background gradeints is now available to use, as per [#28](https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-4.70/issues/28).
* Colours... colours... colours... We now have 26 **new** colours to choose from! Find the `xml` files in the `Palettes` folder, this will be updated regulary, so be sure to come back often! Alternatively, if you would like to request/submit a colour palette, then please submit a base colour in a hexadecimal format plus a suitable name for it on the `New Palette Ideas` issues thread.
* Tinkering with the References.
* Start to fill out the WIX installer project.
* Nearly completed first design stage of the `Update File Creator`.
* New installer project (Advanced Installer & WIX).
* Laid basic foundation for a designable `Krypton MessageBox`.
* Migrated `packages.config` over  to `PackageReference` (must have the latest Visual Studio 2017 Preview build to utilise this feature).
* `KryptonNumericUpDown` control can now be used on menu & toolbar controls.
* Build output paths changed for neatness
* The **releases** tab is now activated
* New XML files labelled `Update.xml` and `CheckSum.xml` have been created to explain to developers how to use the updater back-end.
* TODO: Connect the framework up to UI elements.
* Begun fundamental groundwork on an XML based application updater (classes/settings/UI).
* Improved documentation with the aid of [GhostDoc](https://marketplace.visualstudio.com/items?itemName=sergeb.GhostDoc).
* New wizard control based off of [Aero Wizard](https://github.com/dahall/AeroWizard) base implemented, ready for conversion to Krypton controls
* New "Most Recently Used" files option for `File` menu, see `Playground` for proper implementation
* A new Windows Forms application `Playground` has been added to test controls and features added to the toolkit.
* Added a new toolstrip menu item UAC shield control
* Added/cleaned up documentation for methods
* New setter/getter methods for certain properties in `Global Utilities`
* New method `ElevateProcessWithAdministrativeRights(string processName)` for elevating your application with administrative rights (to be used in conjunction with the recently added UAC shield controls)
* New `CODE_OF_CONDUCT.md` file for project
* Krypton UAC shield button
* New options for developers to check if the user is running Windows 7 or higher. 64-bit checks will follow soon.
* Extended 'KryptonTextBox' to have watermark functionality.
* Wrapped 'KryptonTextBox' into a `toolstrip container` object to make it easier to add new functionality i.e watermarks.
* New icons for `MessageBoxes`
* New `Globals.cs` class for custom enumerations. (Needs documentation finishing off)
* NOTE FOR FUTURE REFRENCE: Find suitable icons for `MessageBoxes` (CC license maybe?)
* Fixed bug with Krypton outlook grid
* Incorporated a `base Krypton MessageBox` as a reference for extending
* Fully incorporated `Krypton Outlook Grid` code
* Altered assembly info
* Variables and comments with `color` renamed to `colour`
* Added generic C# `.gitignore` file
* Created solution with two class projects inside labelled `Extended Controls` and `Krypton Outlook Grid`
* Automatic versioning
* High DPI support configuration 
