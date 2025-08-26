# Jellyfin Plugin Radio

Plugin per Jellyfin che permette di aggiungere e gestire stazioni radio streaming direttamente dall’interfaccia di Jellyfin.

## Funzionalità
- Aggiungi stazioni radio personalizzate
- Interfaccia di configurazione integrata

## Installazione

### Compilazione
1. Clona la repository:
   ```sh
   git clone https://github.com/tuo-username/jellyfin-plugin-radio.git
   ```
2. Installa le dipendenze richieste (vedi sezione sotto).
3. Compila il progetto:
   ```sh
   dotnet build -c Release
   ```
4. Troverai la DLL in: `bin/Release/net8.0/`

### Installazione su Jellyfin
1. Copia `Jellyfin.Plugin.Radio.dll` nella cartella dei plugin di Jellyfin:
   - **Windows**: `%AppData%\Jellyfin\plugins`
   - **Linux**: `/var/lib/jellyfin/plugins`
2. Riavvia Jellyfin.
3. Vai su **Dashboard > Plugin** per configurare.

## Dipendenze

- Le DLL di riferimento (`MediaBrowser.*.dll`, `Jellyfin.Data.dll` ecc) devono essere prese dalla tua installazione Jellyfin o dalla build corrispondente.

## Contribuire

Pull request benvenute! Apri un’issue per funzioni o bug.

## License
[MIT](LICENSE)