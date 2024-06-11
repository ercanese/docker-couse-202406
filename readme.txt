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

#çalıştırma esanısnda container içerisine
docker run -it --name test ubuntu bash

#run esnasında container içerisine girme
docker run -it --name test1213 ubuntu bash
    apt update
    apt install figlet
#çalışan bir containera girmek için.
docker exec -it a23 bash
    apt update
    apt install figlet

#container içerisindeki logları ekranda görmek için.
docker logs <containername or id>
docker logs test3 
#logları sürekli olarak takip etemek için.
docker logs -f test3

#container silmek için.
docker rm <containerid>
#eğer container çalışıyorsa
docker rm <containerid> -figlet
#imaj silmek için
docker rmi <dockerimageid>
#Eğer bağlantılı containerlar varsa
docker rmi <imageid> -figlet

#tüm containerları silmek için
docker rm $(docker ps -qa)
#tüm imajları silmek için.
docker rmi $(docker images -q)

#container imaj kaydetmek için
docker save redis > redis.tar
#container imajını load etmek için
docker load < redis.tar



