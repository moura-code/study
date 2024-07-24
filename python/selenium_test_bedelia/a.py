from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.common.action_chains import ActionChains
import json
driver = webdriver.Chrome()
import time

username = " " #tu user
passsword = " " #Tu contra

try:
    driver.get("https://bedelias.udelar.edu.uy/views/private/desktop/evaluarPrevias/evaluarPrevias02.xhtml?cid=2")

    wait = WebDriverWait(driver, 60)
    username_field = wait.until(EC.presence_of_element_located((By.ID, "username")))
    
    username_field.send_keys(username)
    password_field = driver.find_element(By.ID, "password")
    password_field.send_keys(passsword)

    login_button = driver.find_element(By.NAME, "_eventId_proceed")
    login_button.click()
    
    estudiante_button = driver.find_element(By.LINK_TEXT, "ESTUDIANTE")
    actions = ActionChains(driver)
    actions.move_to_element(estudiante_button).perform()

    link = wait.until(EC.element_to_be_clickable((By.LINK_TEXT, "Evaluar previas")))
    link.click()
    data = []
    for page_number in range(2, 31):
        tbody = wait.until(EC.presence_of_element_located((By.CSS_SELECTOR, "tbody.ui-datatable-data.ui-widget-content")))

        rows = tbody.find_elements(By.TAG_NAME, "tr")

        for row in rows:
            cells = row.find_elements(By.TAG_NAME, "td")
            cell_data = [cell.text for cell in cells]
            data.append(cell_data)
        time.sleep(2)
        got = False
        for i in range(10):
            
            try:
                time.sleep(1)
                next_button = wait.until(EC.element_to_be_clickable((By.CSS_SELECTOR, "span.ui-icon.ui-icon-seek-next")))
                next_button.click()
                got = True
            except:
                pass
            if got:
                break
        time.sleep(2)


    cleaned_data = [list(t) for t in set(tuple(e) for e in data if e)]
    with open('table_data.json', 'w') as json_file:
        json.dump(cleaned_data, json_file, indent=4)
except Exception as e:
    print(e)
finally:
    print("done")
    time.sleep(30)
    driver.quit()



