# DrsProject

A minimal starter project for content built on [DrsFramework](https://github.com/DrStevenWright/DrsFramework),
on Unreal Engine 5.8. Copy or fork it to start a new content project.

## Getting started

Requires Unreal Engine 5.8 (launcher install, or a registered source build such as 5.8-drs).

```
git clone --recurse-submodules https://github.com/DrStevenWright/DrsProject.git
cd DrsProject
powershell -ExecutionPolicy Bypass -File Plugins/DrsFramework/Tools/Bootstrap.ps1 -Build
```

Then open `DrsProject.uproject`. When you start a new project from this one, rename the project, the
module in `Source/`, and `PackageName` in `Config/DefaultEngine.ini`.

## Updating DrsFramework

Point the submodule only at a commit on DrsFramework `main`. The full Git workflow is in
[`Plugins/DrsFramework/Docs/GitWorkflow.md`](Plugins/DrsFramework/Docs/GitWorkflow.md).

```
git -C Plugins/DrsFramework pull origin main
git add Plugins/DrsFramework
git commit -m "chore: update DrsFramework"
```

## Licence

MIT. See [LICENSE](LICENSE).
