#Docker version controlü
docker --version

#Docker imaj reprosu
https://hub.docker.com/

#bir imaj indirmek için
dokcer pull <imagename>
docker pull ubuntu

#tagli bir imaj indirmek için
docker pull <imagename>:<tag>
docker pull ubuntu:22.04

#bir container çalıştırmak için.
docker run <option> <imagename:tag> <cmd> <arg>
docker run --name test ubuntu:22.04 echo "Hello World"
