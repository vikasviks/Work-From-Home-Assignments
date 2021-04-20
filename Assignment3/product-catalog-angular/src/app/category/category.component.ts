import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Category } from './Category';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {

  message: string;
  showMessage: boolean = false;

  categoryId: number;
  categoryName: string;
  categoryCode: string;
  categoryDescription: string;


  searchId: number;
  searchName: string;
  searchCode: string;
  searchDescription: string;

  foundCategory: any;
  found: boolean = false;

  removeId: number;
  removeCode: string;

  addCategory: boolean = false;
  displayCategory: boolean = false;
  deleteCategory: boolean = false;
  searchCategory: boolean = false;

  categoryList: Category[] = [];

  loginForm: FormGroup;

  constructor() {

  }

  ngOnInit(): void {

    this.loginForm = new FormGroup({
      Id: new FormControl(null, [Validators.required]),
      Name: new FormControl(null, [Validators.required]),
      Code: new FormControl(null, [Validators.required]),
      Description: new FormControl(null, [Validators.required]),
    })
  }

  setAddCategory(): void {
    this.addCategory = true;
    this.displayCategory = false;
    this.deleteCategory = false;
    this.searchCategory = false;
  }
  setSearchCategory(): void {
    this.addCategory = false;
    this.displayCategory = false;
    this.deleteCategory = false;
    this.searchCategory = true;
  }

  setDisplayCategory(): void {
    this.addCategory = false;
    this.displayCategory = true;
    this.deleteCategory = false;
    this.searchCategory = false;

  }
  setDeleteCategory(): void {
    this.addCategory = false;
    this.displayCategory = false;
    this.deleteCategory = true;
    this.searchCategory = false;
  }
  
  addCategoryToList(): void {
    var x: Category = {
      Name: this.categoryName,
      Id: this.categoryId,
      Code: this.categoryCode,
      Description: this.categoryDescription
    };
    this.categoryList.push(x);
    this.message = "Added Succesfullly !";
    this.showMessage = true;
  }

  removeCategoryFromList(): void {
    this.categoryList.forEach((p, i) => {
      if (p.Id == this.removeId || p.Code == this.removeCode) {

      }
      this.categoryList.splice(i, 1);
    }
    );
  }
  cancel(): void {
    this.loginForm.reset();
  }
  searchCategoryFromList() {
    this.categoryList.forEach((p) => {
      if (p.Id == this.searchId || p.Code == this.searchCode || p.Name == this.searchName || p.Description == this.searchDescription) {
        this.foundCategory = p;
        this.found = true;
      }
    })
    if (this.found == false) {
      this.showMessage = true;
      this.message = "Category Not found !!!"
    }
    console.log(this.foundCategory)
  }
}
