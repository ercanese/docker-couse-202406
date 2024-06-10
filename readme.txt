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

#tüm containerları ve çalışan containerları görmek için.
docker ps -a
docker ps

#container attach mode da çalıştırmak için
docker run --name redis redis
#detach modda çalıştırmak için
docker -d --name test redis

#container çalışırken sürekli ayakta kalan bir processe ihtiyaç duyar.
docker run --name script5 -d ubuntu sh -c 'while true; do echo "test"; sleep 2; done'

