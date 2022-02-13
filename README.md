# Cay Arpshay

Pig Latin translation library, command-line interface and Web API written in C#

## Getting Started

### Check out the Project

```bash
$ git clone git@github.com:spilth/CayArpshay.git
$ cd CayArpshay
```

### Run the Tests

```bash
$ dotnet test ClassLibTests
```

### Build and Run the Command-Line Interface

```bash
$ dotnet build
$ ./Console/bin/Debug/net6.0/piglatin apple
```

### Run and Use the Web API

```bash
$ dotnet dev-certs https --trust # Trust development HTTPS certificates
$ dotnet run --project WebApi
```

Then in a new terminal tab/window run the following:

```bash
$ open https://localhost:7068/swagger/
$ curl -X GET "https://localhost:7068/Translation?english=apple" -H "accept: text/plain"
```
