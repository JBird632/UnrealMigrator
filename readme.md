# Unreal Migrator

## Description
This tool helps migrate files from one Unreal Engine 4 project to another.

## Instructions
1. Select a source project's root directory
2. Select a target project's root directory
3. Select options (all are on by default)
4. Migrate

**Source Project**: the project you want to copy files from  
**Target Project**: the project you want to copy files to

> Note: you should select the **root** directory for your projects and it should contain your `.uproject` file

### Options
`Migrate Source Code`: Migrate sources C++ files from the "Source Project" to the "Target Project"  
`Migrate Content`: Migrate content files from the "Source Project" to the "Target Project"  
`Migrate Keybinding inputs`: Migrate input keybinds (DefaultInput.ini) from the "Source Project" to the "Target Project"  
`Override API Name`: Override the {project}_API string in header files.  
`Blueprint Rebinding`: Add ActiveClassRedirects to the DefaultEngine.ini to rebind source C++ files to migrated Blueprint files
