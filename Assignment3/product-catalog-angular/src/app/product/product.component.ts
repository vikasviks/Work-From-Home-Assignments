import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Product } from './product';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  message: string;
  showMessage: boolean = false;

  productId: number;
  productName: string;
  productCode: string;
  productCategory : string;
  productDescription: string;
  productSellingPrice : number;

  productManufacturer : string;
  
  removeId: number;
  removeCode: string;

  searchId: number;
  searchName: string;
  searchManufacturer:string;
  searchCode: string;
  searchDescription: string;
  searchCategory : string;
  searchSellingPrice : number;

  foundProduct: any;
  found: boolean = false;

  addProduct: boolean = false;
  displayProduct: boolean = false;
  deleteProduct: boolean = false;
  searchProduct: boolean = false;

  productList: Product[] = [];

  loginForm: FormGroup;

  constructor() {

  }

  ngOnInit(): void {

    this.loginForm = new FormGroup({
      Id: new FormControl(null, [Validators.required]),
      Name: new FormControl(null, [Validators.required]),
      Manufacturer : new FormControl(null,[Validators.required]),
      Code: new FormControl(null, [Validators.required]),
      Category : new FormControl(null,[Validators.required]),
      Description: new FormControl(null, [Validators.required]),
      SellingPrice : new FormControl(null,[Validators.required]),
      
    })
  }

  setAddProduct(): void {
    this.addProduct = true;
    this.displayProduct = false;
    this.deleteProduct = false;
    this.searchProduct = false;
  }
  setSearchProduct(): void {
    this.addProduct = false;
    this.displayProduct = false;
    this.deleteProduct = false;
    this.searchProduct = true;
  }

  setDisplayProduct(): void {
    this.addProduct = false;
    this.displayProduct = true;
    this.deleteProduct = false;
    this.searchProduct = false;

  }
  setDeleteProduct(): void {
    this.addProduct = false;
    this.displayProduct = false;
    this.deleteProduct = true;
    this.searchProduct = false;
  }
  

  addProductToList(): void {
    var x: Product = {
      Name: this.productName,
      Id: this.productId,
      Code: this.productCode,
      Manufacturer :this.productManufacturer,
      Category : this.productCategory,
      SellingPrice: this.productSellingPrice,
      Description: this.productDescription
    };
    this.productList.push(x);
    this.message = "Product Added Succesfullly !";
    this.showMessage = true;
  }

  removeProductFromList(): void {
    this.productList.forEach((p, i) => {
      if (p.Id == this.removeId || p.Code == this.removeCode) {

      }
      this.productList.splice(i, 1);
    }
    );
  }
  cancel(): void {
    this.loginForm.reset();
  }
  searchProductFromList() {
    this.productList.forEach((p) => {
      if (p.Id == this.searchId || p.Code == this.searchCode || p.Name == this.searchName || p.Description == this.searchDescription || 
        p.Manufacturer == this.searchManufacturer || p.SellingPrice == this.searchSellingPrice || p.Category == this.searchCategory) {
        this.foundProduct = p;
        this.found = true;
      }
    })
    if (this.found == false) {
      this.showMessage = true;
      this.message = "Product not found!"
    }
    console.log(this.foundProduct)
  }

}
