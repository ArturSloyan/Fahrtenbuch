# Fahrtenbuch

Unser Unternehmen braucht wegen zunehmender Nachfrage ein Verwaltungsprogram was alles im zusammenhang mit dem Fahrtenbuch was wir bis jetzt geführt haben übernehmen soll und für alle Mitarbeiter einfach durch ein Login einsehbar machen soll.

## Anforderungen

- Anmeldeseite wo sich jeder Mitarbeiter anmelden kann
- Seite um einen neuen Mitarbeiter anzulegen
- Seite um Fahrten zu (erstellen, ändern, löschen)
- Seite um einen neuen Firmenwagen anzulegen
- Tabellenansicht wo man ein pkw auswählen kann und gezeigt wird welche Fahrten mit diesem pkw geplant sind
- Abgabe (ER-Diagramm; Bildliche erklärung der CRUD-Seite von "Fahrten", Feldtypen, Validierungen; Code kommentiert)

## Teschnische Dokumentation

### Datenbank aufsetzen

Ich habe mich für EF-Core (code first approach) und habe sqlite (ein File) als Abspeicherungsmedium entschieden.

#### Abhängigkeiten

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.Sqlite

#### Step by step

1. Dotnet-ef installieren:

```powershell
dotnet tool install --global dotnet-ef
```

2. Initiales erstellen des Datenbankschemas:
    a) Wechsel vom Repoverzeichnis zum .\FahrtenbuchProjektCore\

    ```powershell
    cd .\FahrtenbuchProjektCore\
    ```

    b) 

    ```powershell
    dotnet ef migrations add InitialCreate
    ```

## Benutzer Dokumentation

