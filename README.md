# EF Core migrations

This repo contains code for future reference on how the basics of EF Core migrations work.

## Nuget packages:

Required:

```
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Relational
Npgsql.EntityFrameworkCore.PostgreSQL
```

Optional:

```
Npgsql.EntityFrameworkCore.PostgreSQL.NetTopologySuite
```

## Install tool:

```
dotnet tool install --global dotnet-ef
```

## Commands

Run commands from project directory containing .csproj file.

### Add migration:

```
dotnet ef migrations add Initial -v
```

### Add migration to specific directory:

```
dotnet ef migrations add Initial -o Common/Migrations -v
```

### Run migrations:

```
dotnet ef database update -v
```

### Rollback all migrations:

```
dotnet ef database update 0 -v
```

### Rollback to specific migration:

```
dotnet ef database update <target-migration-name> -v
```

### Remove last migration from code:

```
dotnet ef migrations remove -v
```

### Drop the database:

```
dotnet ef database drop
```

### Creating a bundle

A bundle is a exe that runs the migrations when executed.

```
dotnet ef migrations bundle --self-contained
```
