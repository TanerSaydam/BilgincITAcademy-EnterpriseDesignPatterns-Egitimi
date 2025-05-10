# Clean Architecture Readme

## Scaffold CLI komutu
```dash
dotnet ef dbcontext scaffold "Connection string buraya" Microsoft.EntityFrameworkCore.SqlServer
```

## Scaffold Documentation
```dash
https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli
```

## Docker Kurulum Kodu
```dash
docker run -d --name keycloak -p 8080:8080 -e KEYCLOAK_ADMIN=admin -e KEYCLOAK_ADMIN_PASSWORD=admin 
quay.io/keycloak/keycloak:25.0.2 start-dev
```

## Account Page
```dash
http://localhost:8080/realms/myrealm/account/
```

## API Documentation
```dash
https://www.keycloak.org/docs-api/latest/rest-api/index.html
```