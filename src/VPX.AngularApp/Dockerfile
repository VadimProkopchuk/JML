FROM node:12.16.1-alpine As builder

WORKDIR /usr/src/app

RUN npm install -g @angular/cli@6.0.0
RUN npm install

COPY . .

CMD ng serve --host 0.0.0.0