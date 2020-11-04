## Payment Domain

  mkdir PaymentContext.Domain
  mkdir PaymentContext.Shared
  mkdir PaymentContext.Tests
  dotnet new sln
  cd PaymentContext.Domain
  dotnet new classlib
  cd ..
  cd PaymentContext.Shared
  dotnet new classlib
  cd ..
  cd PaymentContext.Tests
  dotnet new mstest


  dotnet sln add PaymentContext.Domain/PaymentContext.Domain.csproj
  dotnet sln add PaymentContext.Shared/PaymentContext.Shared.csproj
  dotnet sln add PaymentContext.Tests/PaymentContext.Tests.csproj

  dotnet restore
  dotnet build

cd PaymentContext.Domain
dotnet add reference ../PaymentContext.Shared/PaymentContext.Shared.csproj
cd ../PaymentContext.Tests
dotnet add reference ../PaymentContext.Domain/PaymentContext.Domain.csproj
dotnet add reference ../PaymentContext.Shared/PaymentContext.Shared.csproj





cd PaymentContext.Shared   
dotnet add package flunt 

cd PaymentContext.Domain 
dotnet add package flunt  

cd PaymentContext.Domain 
dotnet add package flunt