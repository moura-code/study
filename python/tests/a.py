import pdfplumber

# Path to the PDF file
pdf_path = 'a.pdf'

inscriptos = 0
exonerados = 0
count = 0
apro =0
# Open the PDF file
with pdfplumber.open(pdf_path) as pdf:
    # Iterate through the pages
    for page in pdf.pages:
        # Extract tables from the page
        tables = page.extract_tables()
        for table in tables:
            # Print each table
            for row in table:
                if not row[0]:
                    continue
                count +=1
                try:
                 b = row[2]
                 total = float(b)
                 inscriptos +=1
                 
                 if total> 30:
                        exonerados+=1
                 else:
                        apro +=1
                except:
                    continue
print(exonerados)