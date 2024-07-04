FROM postgres:latest

# Environment variables
ENV POSTGRES_DB dbDocker
ENV POSTGRES_USER postgres
ENV POSTGRES_PASSWORD mysecretpassword

# Copy the SQL script to the Docker container
COPY setup.sql /docker-entrypoint-initdb.d/

# Expose the default PostgreSQL port
EXPOSE 5432
