# AgentX Velocity Dashboard

High-velocity crypto dashboard built with Blazor WebAssembly and live market data from CoinGecko.

## Run

```bash
dotnet restore

dotnet run
```

## Build WASM

```bash
dotnet publish -c Release
```

The published site outputs to:

```
bin/Release/net8.0/publish/wwwroot
```

## Notes

- Uses the public CoinGecko API (no key required).
- Polling interval is set to 12 seconds.
