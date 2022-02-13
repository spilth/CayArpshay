# Cay Arpshay

Pig Latin translation library, command-line interface and Web API written in C#

## Getting Started

To check out the project, run the tests and run the CLI:

```bash
$ git clone git@github.com:spilth/CayArpshay.git
$ cd CayArpshay
$ dotnet test ClassLibTests
$ dotnet build
$ ./Console/bin/Debug/net6.0/piglatin apple
$ dotnet dev-certs https --trust
$ dotnet run --project WebApi
$ open https://localhost:7068/swagger/index.html
$ curl -X GET "https://localhost:7068/Translation?english=apple" -H "accept: text/plain"
```
