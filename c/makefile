# Define variables
CC = g++
CFLAGS =  -Wall -Wextra -Werror
TARGET = program

# Default target
all: $(TARGET)

# Compile the C file to an executable
$(TARGET): $(TARGET).cpp
	$(CC) $(CFLAGS) -o $(TARGET).exe $(TARGET).cpp

# Run the compiled program
run: $(TARGET)
	./$(TARGET).exe

# Clean up by removing the executable
clean: $(TARGET).exe
	del $(TARGET).exe
# Compile, run, and clean in one command
r: all run clean

# Usage message if no target is provided
usage:
	@echo "Usage: make <target>"
	@echo "Targets:"
	@echo "  all         - Compile the C file"
	@echo "  run         - Run the compiled program"
	@echo "  clean       - Remove the executable"
	@echo "  all-in-one  - Compile, run, and clean in one step"
	@echo "  usage       - Show this help message"

.PHONY: all run clean all-in-one usage
