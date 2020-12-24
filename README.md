# 2020-12-24

- 目前是     <TargetFramework>netcoreapp3.1</TargetFramework>
- TODO net5.0

## 要執行先要完成數據庫的設置
- appsettings.json 要注意 (localdb)\\MSSQLLocalDB 的兩個反斜線
  ```
   "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=GloboTicket2Zip;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  ```
  
  
- dotnet restore
- dotnet ef migrations add InitialCreate --project GloboTicket.Services.EventCatalog
- dotnet ef database update  --project GloboTicket.Services.EventCatalog