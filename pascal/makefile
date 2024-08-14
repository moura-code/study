# Makefile for compiling and running a Pascal program with FPC

# Compiler
FPC = fpc

# Compiler options
FPC_OPTIONS = -Co -Cr -gl -Miso

# Source file
SRC = principal.pas

# Executable name
EXE = principal

# Default target
all: run

# Rule to build the executable
$(EXE): $(SRC)
	$(FPC) $(FPC_OPTIONS) $(SRC)

# Rule to run the executable
run: $(EXE)
	./$(EXE)

# Clean up the generated files
clean:
	rm -f $(EXE)
	rm -f $(EXE).o
	rm -f $(EXE).ppu

# Phony targets
.PHONY: all run clean
