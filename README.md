go-unityでのgoでの色々テストするリポジトリ

<!-- TOC -->
* [What we have done in this repository](#what-we-have-done-in-this-repository)
* [require](#require)
* [how to use](#how-to-use)
  * [go](#go)
  * [unity](#unity)
* [update files what generated by protoc](#update-files-what-generated-by-protoc)
  * [go](#go)
  * [unity(C#)](#unity--c#-)
<!-- TOC -->

# What we have done in this repository
1. rest api
2. grpc api

# require
* go 1.17.13
* Unity 2021.3.17f1

# how to use
## go

1. run go file for rest api
`go run hello.go`

2. grpc api for grpc
`go run grpc_server.go`


## unity
1. download grpc [plugin](https://packages.grpc.io/archive/2022/02/cc3de1c3eba4c342c406729649f3c39f829dcdbc-24ad316a-7a17-4194-ac29-a95eceae67c6/index.xml) v2.45
2. import unity new package for plugin it got 1.

# update files what generated by protoc

## go
```bash
protoc --go_out=../go --go_opt=paths=source_relative --go-grpc_out=../go --go-grpc_opt=paths=source_relative user.proto
```

## unity(C#)

# Referenced sites
* [protobufとgrpcのGoコード生成先ディレクトリの指定を、protocコマンドのオプションで行う](https://zenn.dev/richardimaoka/articles/d4337235114a3b)