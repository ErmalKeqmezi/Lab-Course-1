import * as yup from 'yup'

export const validationSchema = yup.object({
    name: yup.string().required("Name of the product is required"),
    brand: yup.string().required("Brand of the product is required"),
    type: yup.string().required("Type of the product is required"),
    price: yup.number().required("Price of the product is required and should be more than 1").moreThan(100),
    quantityInStock: yup.number().required("Quantity of a product is required and should'nt be lower than 0").min(0),
    description: yup.string().required("Description for the product is required"),
    file: yup.mixed().when('pictureUrl', {
        is: (value: string) => !value,
        then: yup.mixed().required("Please provide an image")
    })
}); 