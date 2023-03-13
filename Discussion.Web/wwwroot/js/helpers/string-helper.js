class StringHelper {
    camelToPascal = str => {
        let result = str.replace(/([A-Z])/g, "$1");

        return result.charAt(0).toUpperCase() + result.slice(1);
    }
}