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


#Docker versiyon listeleme komutu

docker version

#Bir imaj indirmek için kullandığımız komut

docker pull docker pull ubuntu

#Tag ile imaj indirmek için.

docker pull : docker pull ubuntu:22.04

#Docker login komutu kullanmadan private bir registryden eğer auth işlemi varsa imaj çekme/gönderme işlemi yapılmadan önce login komutu çalıştırılmalı.

docker login -u hroot -p dasdasd docker.tbb.com docker logout docker.tbb.com

#Localde bulunan imajları listelemek için. docker images

#Bir ubuntu imajından adı demo olan bir container türetin. #İçerisine vi uygulamasını kuralım.

apt update apt install vim exit docker run -it --name ubuntudemo ubuntu /bin/bash

#Tüm containerların sadece idleri listelemek için.

docker ps -qa docker ps -a docker ps

#Containerları silmek için. docker rm

#tüm containerları silmek için docker rm $(docker ps -qa)

#çalışan bir containeri silmek için. docker rm -f

#Containerlar biribirinden izole bir yapıya sahiptir. #Container imajları read-only olarak kullanılmaktadır.

#bir containeri arka planda çalıştırmak için. docker run -d --name : docker run -d --name clock2 jpettzzo/clock

#container durdurmak için kullanılan komutlar.

docker stop #10 saniye süreyle kapatma sinyali gönderir. docker kill #direk olarak containeri kill eder.

#Arka planda 3 adet clock çalışacak şekilde container oluşturalım. #Clock1 olan containeri stop komutu ile. #Clock2 olan containeri kill komutu ile durduralım.

#docker içerisine girmeden logları görüntülemek için kullandığımız komut.

docker logs docker logs -f #çalışan containerin loglarını takip etmek için.

#imajları silmek için kullanılan komut

docker rmi docker rmi 1221 -f

#Container ile imaj arasındaki farkları ekranda görmek için docker diff docker diff 1b52342

#Container imajlarının geçmişi ile ilgili bilgi almak için docker history docker history 1ce2313

#Bir adet ubuntu imajından terminale düşecek şekilde bir container oluşturun. #Oluşturduğunuz bu containeri güncelleyin. #Sonrasında figlet paketini bu containera kuralım.

apt update apt install figlet figlet ercan ese

#Containerdan çıkalım ve imaj ile arasındaki farklara bakalım.

#tüm docker objelerinin konfigürasyonlarını görüntülemek için. docker inspect docker inspect 1c2

#Inspect komutu ile formatlama işlemi yapabiliriz.

docker inspect -f '{{ .JsonObject }}' docker inspect -f '{{ .JsonObject }} / {{ .JsonObject }}'

#Ekranda sadece tüm containerların ismini ve state.status değerini ekranda görelim.

docker inspect $(docker ps -qa) -f '{{ .Name }},{{ .State.Status }}'

#PowerShell uygulamasını container içerisinde çalıştırma. docker run -it --name pwshdemo ubuntu apt update apt install vim -y

apt-get install -y wget apt-transport-https software-properties-common

Get the version of Ubuntu
source /etc/os-release

Download the Microsoft repository keys
wget -q https://packages.microsoft.com/config/ubuntu/$VERSION_ID/packages-microsoft-prod.deb

Register the Microsoft repository keys
dpkg -i packages-microsoft-prod.deb

Update the list of packages after we added packages.microsoft.com
apt-get update ###################################

Install PowerShell
apt-get install -y powershell

pwsh # PowerShell çalışıyormu kontrol et. exit

mkdir /app cd app/

vi Time.ps1 insert için i tuşuna bas altta insert olmalı. shift insert tusu ile komutu yapıştır.

while($true){ Write-Host (Get-Date) Start-Sleep 1 }

:wq! # çıkış

pwsh Time.ps1

ctrl-c

#bir containeri imaj haline getirmek için. docker commit newimagename:tag

#Commit esnasında bir arguman değiştirmek için.

docker commit --change 'WORKDIR /app' --change 'CMD ["pwsh","time.ps1"]'

mkdir demo cd demo git clone https://github.com/ercanese/docker-tr-course.git

cd docker-tr-course/tbbdemo/publish

docker pull mcr.microsoft.com/dotnet/aspnet:7.0

docker run -it --name mvcdemo mcr.microsoft.com/dotnet/aspnet:7.0 mkdir app exit

docker cp . 1231:/app

docker start -i 1231

cd /app dotnet tbbdemo.dll

docker commit --change 'WORKDIR /app' --change 'CMD ["dotnet","tbbdemo.dll"]' mvc mvc:v1

docker run -d -p 8080:80 --name mvcapp01 mvc:v1

#Otomatik olarak build almak için Dockerfile oluşturulmalı ve aşağıdaki komut çalıştırılmalı.

docker build --tag ercan:v1 --file Dockerfile .

Invoke-WebRequest -Uri https://codeload.github.com/ercanese/docker-tr-course/zip/refs/heads/main -OutFile /mnt/deployment.zip Expand-Archive -Path /mnt/deployment.zip -DestinationPath /mnt/

$ImageName = "mvcapp"

[int]$BuildNumber = Get-Content -Path /mnt/buildnumber $BuildNumber += 1 Set-Content -Path /mnt/buildnumber -Value $BuildNumber

($ImageName):$BuildNumber" + "v"

docker build --tag $ImageBuild --file /mnt/docker-tr-course-main/tbbdemo/Dockerfile /mnt/docker-tr-course-main/tbbdemo

Get-ChildItem /mnt/ -Exclude buildnumber | Remove-Item -Recurse -Force

Start-Sleep 5

docker rm app1 -f

Start-Sleep 2

docker run -d -p 8080:80 --name app1 $ImageBuild

#Çalışan bir container içerisine girmek için.

docker exec -it

docker exec -it 121312 /bin/bash

#nfs volume oluşturma

docker volume create --driver local --opt type=nfs --opt o=addr=1.1.1.1,rw --opt device=/mnt/nfsshare --name nfs-volume

#Network oluşturmak için docker network create --gateway 172.16.10.1 --subnet 172.16.10.0/24 br01 docker network ls

docker run -d -p 9099:80 --name demo1 --network br01 mvc:v1 docker connect 23131 br01