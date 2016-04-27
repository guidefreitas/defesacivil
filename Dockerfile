FROM microsoft/dotnet:latest
MAINTAINER "Guilherme Defreitas Juraszek"
COPY . /app
WORKDIR /app/src/DefesaCivil.Web
RUN apt-get update
RUN apt-get install libunwind8
RUN dnvm upgrade -r coreclr
RUN dnvm use 1.0.0-rc1-update2 -r coreclr
RUN dnu restore

# Open this port in the container
EXPOSE 5000
# Start application
#ENTRYPOINT ["dnx","-p","project.json", "web"]

#docker build -t yourapplication .
#docker run -t -d -p 8080:5000 defesacivil-dotnet-app