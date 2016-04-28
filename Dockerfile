FROM microsoft/aspnet:1.0.0-rc1-update1-coreclr
MAINTAINER "Guilherme Defreitas Juraszek"
COPY . /app
WORKDIR /app/src/DefesaCivil.Web
#RUN dnvm list
RUN /opt/DNX_BRANCH/runtimes/dnx-coreclr-linux-x64.1.0.0-rc1-update1/bin/dnu restore --no-cache
RUN mkdir ~/Temp
RUN /opt/DNX_BRANCH/runtimes/dnx-coreclr-linux-x64.1.0.0-rc1-update1/bin/dnu publish . --out ~/Temp/ --wwwroot-out "wwwroot" --quiet; exit 0
WORKDIR /root/Temp/approot
# Open this port in the container
ENV Hosting:Environment Production
EXPOSE 5000
# Start application
ENTRYPOINT ["./web"]
#docker build -t guidefreitas/defesacivil .
#docker run -p 5000:5000 -it guidefreitas/defesacivil