# SmartHomeHub (Design Patterns)

En enkel konsolapplikation i C#/.NET som demonstrerar flera designmönster i ett “smart home”-scenario:
lampor, termostat och dörrlås kan styras via modes (t.ex. Night/Away) och loggas/visas via observers.

## Hur man kör programmet

### Krav
- .NET SDK (t.ex. .NET 8)

### Körning
Från repo-root:

```bash
dotnet restore
dotnet build
dotnet run --project src/SmartHomeHub/SmartHomeHub.csproj
