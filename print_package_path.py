import re


def print_package_path():
    with open('packageoutput', 'r') as file:
        packageoutput = file.read()
    x = re.search("(?<= Successfully created package ')[\\w\\:\\\\\\-\\.]*(?=')", packageoutput)
    print(x.group())


# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    print_package_path()

