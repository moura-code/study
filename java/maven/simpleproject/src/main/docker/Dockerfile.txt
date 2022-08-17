FROM dockerfile/java:oracle-java8

ADD simpleproject.jar /opt/simpleproject/
EXPOSE 8080
WORKDIR /opt/simpleproject/
CMD ["java", "-Xms512m", "-Xmx1g", "-jar", "simpleproject.jar"]