docker stop mongo-things
docker rm mongo-things
docker run -p 27017:27017 --name mongo-things mongo