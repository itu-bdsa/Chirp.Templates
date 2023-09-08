# Templates for Razor and Blazor

## Pack to NuGet package

1. Make sure that you are in this folder
2. Run: ```dotnet pack -o .```

> If no output is set, then the file will be placed in `bin/Release`

## How to use it?

Find the latest release [here](https://github.com/itu-bdsa/Chirp.Templates/releases/latest)

From there,:

  * download the package, e.g.,
    ```bash
    wget https://github.com/itu-bdsa/Chirp.Templates/releases/download/v1.0.1/BDSA.TEMPLATES.1.0.1.nupkg
    ```
  * Install the template package
    ```bash
    dotnet new install BDSA.TEMPLATES.1.0.1.nupkg
    ```
  * And use the new templates, e.g.,
    ```bash
    dotnet new chirp-razor -o Chirp.Razor
    ```

Currently, the package bundles two templates: `chirp-razor` and `chirp-blazor`.

## Development

To automatically create a new release, tag a new version and push it to main, e.g.,

```bash
git tag v1.1.1
git push origin v1.1.1
```

--------------------------------------------------------------------------------------------

## Attributions

The CSS files `style.css` are adapted from Armin Ronacher's original version that was provided with his [Flask example application MiniTwit](https://github.com/pallets/flask/blob/0.12.x/examples/minitwit/minitwit/static/style.css).
