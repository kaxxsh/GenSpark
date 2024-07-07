### Work

Creating a simple Docker image to execute a Python program that prints "Hello, World!" involves several steps:

1. *Write the Python script.*
2. *Create a Dockerfile.*
3. *Build the Docker image.*
4. *Run a Docker container using the image.*

### Summary

Here is the summary of the steps:

1. Create python.py:

   python
   print("Hello, World!")
   

2. Create Dockerfile:

   Dockerfile
   FROM python:3.9-slim
   WORKDIR /app
   COPY . /app
   CMD ["python", "python.py"]
   

3. Build the Docker image:

   sh
   docker build -t hello-world-python .
   

4. Run the Docker container:
   sh
   docker run hello-world-python
