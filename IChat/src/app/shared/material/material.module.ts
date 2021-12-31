import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MatCommonModule } from '@angular/material/core';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatCardModule } from '@angular/material/card';
import { MatDialogModule } from '@angular/material/dialog';
import { MatBadgeModule } from '@angular/material/badge';
import { MatButtonModule } from '@angular/material/button';
import { MatDividerModule } from '@angular/material/divider';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatInputModule } from '@angular/material/input';

@NgModule({
  imports: [
    CommonModule
  ],
  exports: [
    MatCommonModule,
    MatToolbarModule,
    MatCardModule,
    MatDialogModule,
    MatBadgeModule,
    MatButtonModule,
    MatDividerModule,
    MatFormFieldModule,
    MatIconModule,
    MatListModule,
    MatProgressBarModule,
    MatInputModule,

  ]

})
export class MaterialModule { }
