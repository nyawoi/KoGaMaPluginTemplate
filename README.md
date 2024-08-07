# KoGaMa Plugin Template

A modding template for [KoGaMa](https://www.kogama.com/), powered by [BepInEx](https://github.com/BepInEx/BepInEx).

## Features

This template is designed to work out-of-the-box: that means you can click `Build` and it'll just work.

- Batteries-included: already configured for modding
- Customizable with feature toggles
- Validates game and mod loader installation
- Automatically installs your plugins
- Copies assets to your mod folder
- Embeds resources if needed

## Requirements

- [KoGaMa Standalone Client](https://www-gamelauncher.kogstatic.com/www/KogamaLauncher.msi)
- [BepInEx 6.0.0-be](https://builds.bepinex.dev/projects/bepinex_be)
- [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) or [newer](https://dotnet.microsoft.com/en-us/download)
- .NET IDE of choice

> [!NOTE]
> **Using [Visual Studio Community 2022](https://visualstudio.microsoft.com/vs/community/)?**
> 
> The **.NET Desktop Development** workload includes `.NET 8.0 SDK`.  
> This means you do not need to install `.NET 6.0 SDK`.

## Getting Started

This guide will help you get started with modding KoGaMa in just a few minutes.

### Installing BepInEx

Installing BepInEx is incredibly easy and won't take much time.

First, open your client's installation folder. You can do this by pressing `Win + R` on your keyboard and pasting the following location.  
`%LocalAppData%\KogamaLauncher-WWW\Launcher\Standalone`  
This will open the game folder in Windows Explorer. If it didn't appear on screen, click on the Explorer icon in the taskbar or tab over to it.

Next, extract the BepInEx ZIP file. This will result in four files and two folders: `changelog.txt`, `doorstop_config.ini`, `.doorstop_version`, `winhttp.dll`, and a `BepInEx` and `dotnet` folder.

Drag everything into the `Standalone` folder. The `BepInEx` and `dotnet` folders should now be next to the `kogama_Data` folder.

Run the game (running the `kogama.exe` file is enough) and wait for the game to load.  
**You're done!** BepInEx is now installed. You may now close the game.

For a more comprehensive guide on [installing BepInEx](https://docs.bepinex.dev/master/articles/user_guide/installation/index.html), as well as several articles on [using it](https://docs.bepinex.dev/master/articles/user_guide/configuration.html), please refer to the [official BepInEx documentation site](https://docs.bepinex.dev/master/index.html).

### Installing the template

Much like BepInEx, installing the template is very simple.

First, [clone the repository](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository) or [download the source code from Releases](https://github.com/nyawoi/KoGaMaPluginTemplate/releases). If downloaded, extract the ZIP file.  
Be sure to move the folder somewhere safe where you know it won't be deleted or overwritten.

Next, open the folder. Inside, you'll see two scripts: `install.sh` and `uninstall.sh`. Run `install.sh` to add the template to your list of .NET templates, and `uninstall.sh` to remove it.

That's it! The template is now installed and ready to create projects.

### Creating a project

Launch your .NET IDE of choice and open the list of available templates.  
If using Visual Studio Community 2022, this is done by clicking on "Create a new project" on the right.

If the template isn't immediately visible, use the search bar to filter the results.  
Visual Studio Community 2022 should automatically display the template at the top of the list after installing it, then will list it on the left, under "Recent project templates".

Select the template and start customizing it. Give it a name, and list yourself as the author.

Create the project and you're done!  
The template takes care of all references for you, so you can focus on what really matters, rather than mess with project configuration.

### Customizing your project

The template comes with some optional features you might find useful. They can be toggled on and off easily, and are separate from the main project, so you can share your code without worrying about it conflicting with someone else's settings.

Open the `*.csproj.user` file and customize the settings.  
If you're using a custom launcher or targetting a different server, this is where you can enter your client's installation location.

When done customizing your plugin base, click on `Build` in your IDE.  
If the task is enabled, your plugin will automatically be installed. Open the game and test it out!

When ready to publish, don't forget to [add a license](https://choosealicense.com/)! This is very important in the open source community.

### Assets and Resources

If your plugin has assets, create a folder named `assets` and it'll automatically be copied over to your mod folder when building your project.

Likewise, if you have embedded resources, create a folder named `resources` and those will automatically be embedded when building.
