FROM python:3.10.14-alpine3.19
WORKDIR /app

RUN pip install flask
COPY . .
LABEL  ortam="prod"
EXPOSE 9090
CMD [ "flask","run","--host=0.0.0.0","--port=9090" ]